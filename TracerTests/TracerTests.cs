using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TracerApp.Tests
{
    [TestClass()]
    public class TracerTests {
        private int waitTime = 200;

        [TestMethod()]
        public void AnyMethod() {
            Tracer tracer = new Tracer();
            tracer.StartTrace();
            Thread.Sleep(waitTime);
            tracer.StopTrace();
        }

        [TestMethod()]
        public void AnyMethod2() {
            Tracer tracer = new Tracer();
            tracer.StartTrace();
            AnyMethod3();
            AnyMethod3();
            tracer.StopTrace();
        }

        [TestMethod()]
        public void AnyMethod3() {
            Tracer tracer = new Tracer();
            tracer.StartTrace();
            Thread.Sleep(waitTime / 2);
            tracer.StopTrace();
        }
    }
}