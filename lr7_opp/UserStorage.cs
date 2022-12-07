using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lr7_opp
{
    internal class UserStorage
    {
        private Dictionary<AuthorizeInfo, UserInfo> data;

        public UserStorage()
        {
            data= new Dictionary<AuthorizeInfo, UserInfo>();
            data.Add(new AuthorizeInfo("Ников", "1"), new UserInfo("Ников О.К.", "Nikov.O.K.@mail.ru", "Stavropol"));
            data.Add(new AuthorizeInfo("Жерикин", "2"), new UserInfo("Жерикин М.К.", "Jerikin.M.K.@mail.ru", "Stavropol"));
            data.Add(new AuthorizeInfo("Китова", "3"), new UserInfo("Китова А.Е.", "Kitova.A.E.@mail.ru", "Moscow"));
            data.Add(new AuthorizeInfo("Жернова", "4"), new UserInfo("Жернова А.С.", "Jernova.A.S.@mail.ru", "New-York"));
        }

        public UserInfo GetUser(AuthorizeInfo ob)
        {
            if(data.ContainsKey(ob)) return data[ob];
            else return null;
        }
    }
}
