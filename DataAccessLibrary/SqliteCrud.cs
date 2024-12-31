using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class SqliteCrud
    {
        private readonly string _connectionString;
        private SqlliteDataAccess db = new SqlliteDataAccess();
        public SqliteCrud(string connectionString)
        {
            _connectionString = connectionString;
        }

        public List<BasicContactModel> GetAllContacts()
        {
            string sql = "select Id, FirstName, LastName from Contacts";
            return db.LoadData<BasicContactModel, dynamic>(sql, new { }, _connectionString);
        }

        public FullContactModel GetFullContactById(int id)
        {
            FullContactModel output = new FullContactModel();

            string sql = "select Id, FirstName, LastName from Contacts where Id = @Id";
            output.BasicInfo = db.LoadData<BasicContactModel, dynamic>(sql, new { Id = id }, _connectionString).FirstOrDefault() ?? new BasicContactModel();

            if (output.BasicInfo.FirstName == "")
            {
                return null;
            }
            sql = "select pn.Id, pn.PhoneNumber from PhoneNumbers pn join ContactPhoneNumbers cpn on pn.Id = cpn.PhoneId where cpn.ContactId = @Id";
            output.PhoneNumbers = db.LoadData<PhoneNumberModel, dynamic>(sql, new { Id = id }, _connectionString);

            sql = "select ea.Id, ea.EmailAddress from EmailAddresses ea join ContactEmails cea on ea.Id = cea.EmailId where cea.ContactId = @Id";
            output.EmailAddresses = db.LoadData<EmailAddressModel, dynamic>(sql, new { Id = id }, _connectionString);

            return output;
        }

        public void CreateContact(FullContactModel contact)
        {
            //save the basic contact
            string sql = "insert into Contacts (FirstName, LastName) values (@FirstName, @LastName);";
            db.SaveData(sql, new { contact.BasicInfo.FirstName, contact.BasicInfo.LastName }, _connectionString);
            //get the id from the basic contact
            sql = "select Id from Contacts where FirstName = @FirstName and LastName = @LastName;";
            int contactId = db.LoadData<IdLookupModel, dynamic>(sql, new { contact.BasicInfo.FirstName, contact.BasicInfo.LastName }, _connectionString).First().Id;

            foreach (PhoneNumberModel number in contact.PhoneNumbers)
            {
                if (number.Id == 0)
                {
                    sql = "insert into PhoneNumbers (PhoneNumber) values (@PhoneNumber);";
                    db.SaveData(sql, new { number.PhoneNumber }, _connectionString);

                    sql = "select Id from PhoneNumbers where PhoneNumber = @PhoneNumber;";
                    number.Id = db.LoadData<IdLookupModel, dynamic>(sql, new { number.PhoneNumber }, _connectionString).First().Id;
                }
                sql = "insert into ContactPhoneNumbers (ContactId, PhoneId) values (@ContactId, @PhoneId);";
                db.SaveData(sql, new { ContactId = contactId, PhoneId = number.Id }, _connectionString);
            }

            foreach (EmailAddressModel emailAddress in contact.EmailAddresses)
            {
                if (emailAddress.Id == 0)
                {
                    sql = "insert into EmailAddresses (EmailAddress) values (@EmailAddress);";
                    db.SaveData(sql, new { emailAddress.EmailAddress }, _connectionString);
                    sql = "select Id from EmailAddresses where EmailAddress = @EmailAddress;";
                    emailAddress.Id = db.LoadData<IdLookupModel, dynamic>(sql, new { emailAddress.EmailAddress }, _connectionString).First().Id;
                }
                sql = "insert into ContactEmails (ContactId, EmailId) values (@ContactId, @EmailId);";
                db.SaveData(sql, new { ContactId = contactId, EmailId = emailAddress.Id }, _connectionString);
            }
        }

        public void UpdateContactName(BasicContactModel contact)
        {
            string sql = "update Contacts set FirstName = @FirstName, LastName = @LastName where Id = @Id;";
            db.SaveData(sql, contact, _connectionString);
        }

        public void RemovePhoneNumber(int contactId, int phoneId)
        {
            string sql = "select Id, ContactId, PhoneId from ContactPhoneNumbers where PhoneId = @PhoneId;";
            var links = db.LoadData<ContactPhoneNumberModel, dynamic>(sql, new { PhoneId = phoneId }, _connectionString);

            sql = "delete from ContactPhoneNumbers where PhoneId = @PhoneId and ContactId = @ContactId;";
            db.SaveData(sql, new { PhoneId = phoneId, ContactID = contactId }, _connectionString);

            if (links.Count == 1)
            {
                sql = "delete from PhoneNumbers where Id = @Id;";
                db.SaveData(sql, new { Id = phoneId }, _connectionString);
            }
        }
    }
}
