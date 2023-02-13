using BackEnd_Project.Services.Interfaces;

namespace BackEnd_Project.Services
{
    public class SumService : ISum
    {
        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
