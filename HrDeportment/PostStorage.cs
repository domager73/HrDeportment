using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HrDeportment
{
    public class PostStorage
    {
        public static List<string> Posts { get; private set; } = new List<string>() {
            "Деректор",
            "Уборщица",
            "Сеньер",
            "Мидле",
            "Джун"};
    }
}
