using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Model.Provider
{
    public interface IProvider
    {
        bool Login(string userName, string password);
        void Logout();

        ObservableCollection<MemberModel> GetMembers(string sortExpression);
        MemberModel GetMember(int memberId);

        void AddMember(MemberModel member);
        void UpdateMember(MemberModel member);
        void DeleteMember(int memberId);

        ObservableCollection<OrderModel> GetOrders(int memberId);
    }
}
