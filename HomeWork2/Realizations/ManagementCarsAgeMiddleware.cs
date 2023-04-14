using HW2.Interfaces;

namespace HomeWork2.Realizations
{
    public class ManagementCarsAgeMiddleware
    {
        RequestDelegate next;

        public ManagementCarsAgeMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext context, IManagementCars managementCars)
        {
            await context.Response.WriteAsync($"Car model: {managementCars?.GetCarAge()}\n");
        }
    }
}
