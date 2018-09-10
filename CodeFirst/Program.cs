using EFDemo.CodeFirstDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst
{
    /// <summary>
    /// 1 O/RM对象关系映射
    /// 2 EntityFramework DBFirst
    /// 3 EntityFramework codeFirst from db &&codeFirst 
    /// 4 EntityFramework modelFirst
    /// 5 EF的增删改查
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //dbContext其实是空对象，没有任何数据，只有一个数据库连接
                //正常查询会把结果缓存到对象，任何的修改，一次事务性的save  (多个表一样)
                using (CodeFirstContext dbContext = new CodeFirstContext())
                {
                    dbContext.Database.Log += c => Console.WriteLine(c);
                    User user2 = dbContext.User.Find(2);
                    User user3 = dbContext.User.Find(3);

                    var list = dbContext.User.ToList();

                    var list2 = dbContext.User.Where(u => u.Id < 3);//延迟查询

                    var list4 = list2.Where(u => u.Name.Length < 3).OrderBy(u => u.Id);

                    foreach (var item in list4)
                    {

                    }

                    var list3 = dbContext.User.Where(u => u.Id < 3).ToList();
                    User userNew = new User()
                    {
                        Account = "Admin",
                        State = 0,
                        CompanyId = 4,
                        CompanyName = "万达集团",
                        CreateTime = DateTime.Now,
                        CreatorId = 1,
                        Email = "57265177@qq.com",
                        LastLoginTime = null,
                        LastModifierId = 0,
                        LastModifyTime = DateTime.Now,
                        Mobile = "18664876671",
                        Name = "yoyo",
                        Password = "12356789",
                        UserType = 1
                    };
                    dbContext.User.Add(userNew);
                    dbContext.SaveChanges();

                    user2.Name = "远影入梦";
                    userNew.Name = "安德鲁";
                    dbContext.SaveChanges();

                    dbContext.User.Remove(userNew);
                    dbContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
            }
        }
    }
