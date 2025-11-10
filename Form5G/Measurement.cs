using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Form5G
{
    internal class Measurement
    {
        public class TestCase
        {
            public string Name { get; set; }
            public bool IsChecked { get; set; }
        }

        public class Port
        {
            public string Id { get; set; }
            public bool IsChecked { get; set; }
        }

        public void RunTestCases(List<TestCase> testCases, List<Port> ports)
        {
            foreach (var testCase in testCases.Where(tc => tc.IsChecked))
            {
                Console.WriteLine($"🔧 Đang thực hiện test case: {testCase.Name}");

                foreach (var port in ports.Where(p => p.IsChecked))
                {
                    var result = Measure(testCase, port);
                    LogResult(testCase, port, result);
                }

                Console.WriteLine($"✅ Hoàn tất test case: {testCase.Name}\n");
            }

            Console.WriteLine("🎉 Đã hoàn tất tất cả các test case được chọn.");
        }
        public string Measure(TestCase testCase, Port port)
        {
            // Giả lập đo kiểm
            Console.WriteLine($"Đo kiểm tại PORT {port.Id} cho {testCase.Name}...");
            Thread.Sleep(500); // giả lập thời gian đo
            return "PASS"; // hoặc "FAIL"
        }

        public void LogResult(TestCase testCase, Port port, string result)
        {
            Console.WriteLine($"Kết quả: {testCase.Name} - PORT {port.Id} => {result}");
        }


    }


}
