using JSONApiApp.Model.Entity;
using JSONApiApp.Service;

namespace JSONApiApp.Controlles
{
    public class ControllerConvertInfo
    {
        private ServiceConvertInfo convertInfo;

        public ControllerConvertInfo(ServiceConvertInfo convertDistance)
        {
            this.convertInfo = convertDistance;
        }

        //Обработчик конверта величины
        public async Task ConvertNumber(HttpContext context)
        {


            Number NewNumber = await context.Request.ReadFromJsonAsync<Number>();

            convertInfo.ToSimple(NewNumber.nameNumberInput, NewNumber.number);
            double number= convertInfo.GetConverter(NewNumber.nameNumberOutput);
            await context.Response.WriteAsJsonAsync(number);

        }
    }
}
