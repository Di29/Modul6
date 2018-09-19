using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkClasses
{
    public class Method
    {
        public static string GetParametres(Person person)
        {
            string parametres = ($"Фамилия: {person.FirstName},\n" + $"Имя: {person.LastName},\n" + $"Национальность: {person.Nationality},\n" + $"Возраст: {person.Age},\n" + $"Вес: {person.Weight}");
            return parametres;
        }


    }
}
