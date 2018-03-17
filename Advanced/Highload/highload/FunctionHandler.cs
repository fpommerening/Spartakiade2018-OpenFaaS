using System;
using System.Threading.Tasks;

namespace Function
{
    public class FunctionHandler
    {
        public Task<string> Handle(string input)
        {
            return Task.FromResult($"##{input}##");
        }
    }
}
