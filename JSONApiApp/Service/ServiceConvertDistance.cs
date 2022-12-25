namespace JSONApiApp.Service
{
    public class ServiceConvertDistance
    {
        public double UnitOutput { get; set; }//Выводимая величина
        public double UnitInput { get; set; }//Вводимая величина

        //Перевод вводимой величины в метры
        public void ToMeter(string NameUnit,double number)
        {
            switch (NameUnit)
            {
                case "Meter":
                    UnitInput = number * 1;
                    break;

                case "Kilometer":
                    UnitInput = number * 1000;
                    break;

                case "Milimeter":
                    UnitInput = number / 1000;
                    break;

                case "Centimeter":
                    UnitInput = number / 100;
                    break;

                case "Yards":
                    UnitInput = number * 1.09361;
                    break;

                case "lb.":
                    UnitInput = number * 3.28084;
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
                case "Meter":
                    return UnitInput * 1;
                    break;

                case "Kilometer":
                    return UnitInput / 1000;
                    break;

                case "Milimeter":
                    return UnitInput * 1000;
                    break;

                case "Centimeter":
                    return UnitInput * 100;
                    break;

                case "Yards":
                    return UnitInput / 1.09361;
                    break;

                case "lb.":
                    return UnitInput / 3.28084;
                    break;

                default:
                    return 0;
                    break;
            }
        }
    }
}
