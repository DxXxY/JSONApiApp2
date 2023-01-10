using JSONApiApp.Model.Entity;
using JSONApiApp.Model;

namespace JSONApiApp.Service
{
    public class ServiceMyRequest
    {
        //Получение списка хостов
        public List<MyRequest> GetMyRequest()
        {
            using (var db = new JsonApiDbContext())
            {
                return db.MyRequests.ToList();
            }
        }

        //Добавление хоста
        public MyRequest AddKnowHost(MyRequest request)
        {
            using (var db = new JsonApiDbContext())
            {
                db.MyRequests.Add(request);
                db.SaveChanges();
                return request;
            }
        }
        //Изменение хоста
        public MyRequest UpdateMyRequest(int id, string info)
        {
            using (var db = new JsonApiDbContext())
            {
                MyRequest updateRequest = db.MyRequests.FirstOrDefault(h => h.Id == id);
                updateRequest.info = info;
                db.SaveChanges();
                return updateRequest;
            }
        }
        //удаление хоста
        public MyRequest DeleteMyRequest(int id)
        {
            using (var db = new JsonApiDbContext())
            {
                MyRequest deleteRequest = db.MyRequests.FirstOrDefault(h => h.Id == id);
                db.MyRequests.Remove(deleteRequest);
                db.SaveChanges();
                return deleteRequest;
            }
        }
    }
}
