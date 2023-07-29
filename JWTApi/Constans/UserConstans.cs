using JWTApi.Models;

namespace JWTApi.Constans
{
    public class UserConstans
    {
        public static List<UserModel> Users = new List<UserModel>()
        {
            new UserModel() {UserName="julio", Password="1234", EmailAddress="julio@gmail.com", FirstName="Julio", LastName="Sanchez", Rol="Administrador"},
            new UserModel() {UserName="cesar", Password="1234", EmailAddress="cesar@gmail.com", FirstName="Cesar", LastName="Maria", Rol="Vendedor"}
        };
    }
}
