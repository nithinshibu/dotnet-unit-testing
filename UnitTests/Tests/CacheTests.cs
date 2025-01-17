﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTests.Units;

namespace UnitTests.Tests
{
    public class CacheTests
    {
        [Fact]

        public void CachesItemsWithinTimeSpan()
        {
            var cache = new Cache(TimeSpan.FromDays(1));

            cache.Add(new ("url", "content", DateTime.Now));

            var contains = cache.Contains("url");

            Assert.True(contains);
        }


        [Fact]
        public void Contains_ReturnsFalse_WhenOutsideTimeSpan()
        {
            var cache = new Cache(TimeSpan.FromDays(1));

            cache.Add(new("url", "content", DateTime.Now.AddDays(-2)));

            var contains = cache.Contains("url");

            Assert.False(contains);
        }

        [Fact]
        public void Contains_ReturnsFalse_WhenDoesnotContainItem()
        {
            var cache = new Cache(TimeSpan.FromDays(1));

            var contains = cache.Contains("url");

            Assert.False(contains);
        }

    }
}
