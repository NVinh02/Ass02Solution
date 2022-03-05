using System.Data;
using Microsoft.Data.SqlClient;
using BusinessObject;
using DataAccess.DataProvider;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace DataAccess
{
    public class MemberDAO : BaseDAL
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<Member> GetMemberList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select * " +
                "From Member";
            var members = new List<Member>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                while (dataReader.Read())
                {
                    members.Add(new Member
                    {
                        MemberId = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5)
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;
        }

        public Member GetMemberByID(int memberID)
        {
            Member member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberId, Email, CompanyName, City, Country, Password " +
                "  From Member where MemberId = @MemberId";
            try
            {
                var param = dataProvider.CreateParameter("@MemberId", 4, memberID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new Member
                    {
                        MemberId = dataReader.GetInt32(0),
                        Email = dataReader.GetString(1),
                        CompanyName = dataReader.GetString(2),
                        City = dataReader.GetString(3),
                        Country = dataReader.GetString(4),
                        Password = dataReader.GetString(5)
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }

        public void AddNew(Member member)
        {
            try
            {
                Member pro = GetMemberByID(member.MemberId);
                if (pro == null)
                {
                    string SQLInsert = "Insert Member values(@MemberId,@Email,@CompanyName,@City,@Country,@Password)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, member.MemberId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CompanyName", 40, member.CompanyName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 15, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 15, member.Country, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 30, member.Password, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The member is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Update(Member member)
        {
            try
            {
                Member m = GetMemberByID(member.MemberId);
                if (m != null)
                {
                    string SQLUpdate = "Update Member set Email = @Email," +
                        "CompanyName = @CompanyName, City = @City, Country = @Country, Password = @Password where MemberId = @MemberId";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberId", 4, member.MemberId, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@Email", 100, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@CompanyName", 40, member.CompanyName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 15, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 15, member.Country, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 30, member.Password, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The member does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Remove(int memberID)
        {
            try
            {
                Member member = GetMemberByID(memberID);
                if (member != null)
                {
                    string SQLDelete = "Delete Member where MemberId = @MemberId";
                    var param = dataProvider.CreateParameter("@MemberId", 4, memberID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, param);
                }
                else
                {
                    throw new Exception("The member does not exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }

        public Member CheckLogin(string email, string password)
        {
            Member member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberId, Email, CompanyName, City, Country " +
                "  From Member where Email = @Email and Password = @Password";
                try
                {
                    var param = new List<SqlParameter>();
                    param.Add(dataProvider.CreateParameter("@Email", 50, email, DbType.String));
                    param.Add(dataProvider.CreateParameter("@Password", 50, password, DbType.String));

                    dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param.ToArray());
                    if (dataReader.Read())
                    {
                        member = new Member
                        {
                            MemberId = dataReader.GetInt32(0),
                            Email = dataReader.GetString(1),
                            CompanyName = dataReader.GetString(2),
                            City = dataReader.GetString(3),
                            Country = dataReader.GetString(4),
                            Password = dataReader.GetString(5)
                        };
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    dataReader.Close();
                    CloseConnection();
                }
            return member;
        }
    }
}
