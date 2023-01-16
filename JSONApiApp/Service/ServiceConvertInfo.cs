namespace JSONApiApp.Service
{
    public class ServiceConvertInfo
    {
        public double UnitOutput { get; set; }//Выводимая величина
        public double UnitInput { get; set; }//Вводимая величина

        //Перевод вводимой величины в метры
        public void ToSimple(string NameUnit,double number)
        {
            switch (NameUnit)
            {
                case "byte":
                    UnitInput = number * 1;
                    break;

                case "Kbyte":
                    UnitInput = number * 1024;
                    break;

                case "Mbyte":
                    UnitInput = number * 1024 * 1024;
                    break;

                case "Gbyte":
                    UnitInput = number  *1024 * 1024 * 1024;
                    break;

                case "Ter":
                    UnitInput = number * 1024 * 1024 * 1024 * 1024;
                    break;


                default:
                    break;
            }
        }

        //Конвертер величины
        public double GetConverter(string UnitNameOutput)
        {
            switch (UnitNameOutput)
            {
                case "byte":
                    return UnitInput * 1;
                    break;

                case "Kbyte":
                    return UnitInput / 1024;
                    break;

                case "Mbyte":
                    return UnitInput / 1024 / 1024;
                    break;

                case "Gbyte":
                    return UnitInput / 1024 / 1024 / 1024;
                    break;

                case "Ter":
                    return UnitInput / 1024 / 1024 / 1024 / 1024;
                    break;

                default:
                    return 0;
                    break;
            }
        }
    }
}
