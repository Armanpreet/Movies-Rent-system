
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoviesRentalSystems;


namespace moviRentalSystemTest
{
    [TestClass]
    public class UnitTest1
    {
        Form1 form = new Form1();
        [TestMethod]
        public void ConnectionTest()
        {
            
            if(form.conn ==null)
            {
                form.Connection = false;

            }
            else
            {
                form.Connection = true;
                
            }
            Assert.IsTrue(form.Connection);
        }

        [TestMethod]
        public void Show_Lists_Test()
        {
            bool rtrnMov = form.Show_Lists;
            Assert.IsTrue(rtrnMov);

        }

    }
}
