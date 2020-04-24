using System;
using System.Linq;
using Xunit;

namespace EFCorePlus.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            using (var dbContext = new TestDbContext())
            {
                dbContext.tESTENTITies.Add(new TESTENTITY() { Id = "1" });
                var initData = new { ttt = "123" };
                dbContext.tESTENTITies.Where(t => t.Id != null).UpdateFromQuery(t => new
                {
                    TESTENTITY2ID = t.TESTENTITY2ID + initData.ttt,
                    COMMENT = "123321"
                });

            }
        }
    }
}
