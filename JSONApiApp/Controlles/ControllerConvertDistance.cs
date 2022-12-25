using JSONApiApp.Service;

namespace JSONApiApp.Controlles
{
    public class ControllerConvertDistance
    {
        private ServiceConvertDistance convertDistance;

        public ControllerConvertDistance(ServiceConvertDistance convertDistance)
        {
            this.convertDistance = convertDistance;
        }

        //Обработчик конверта величины
        public async Task ConvertNumber(HttpContext context)
        {
            double numberInput = Convert.ToDouble(context.Request.Query["number"]);
            string nameUnitInput = context.Request.Query["nameUnitInput"];
            string nameUnitOutput = context.Request.Query["nameUnitOutput"];
            convertDistance.ToMeter(nameUnitInput, numberInput);
            double number= convertDistance.GetConverter(nameUnitOutput);
            await context.Response.WriteAsJsonAsync(number);

        }
    }
}
