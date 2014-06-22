﻿#region License

//-----------------------------------------------------------------------
// <copyright>
// The MIT License (MIT)
// 
// Copyright (c) 2014 Kirk S Woll
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
// </copyright>
//-----------------------------------------------------------------------

#endregion

using System.Runtime.WootzJs;
using System.Threading.Tasks;
using WootzJs.Testing;

namespace WootzJs.Compiler.Tests
{
    [TestFixture]
    public class AsyncTests
    {
        private bool basicTestAsync;
        private bool basicTestTaskAsync;

        [Test]
        public void BasicTest()
        {
            BasicTestAsync();
            basicTestAsync.AssertTrue();
        }

        async void BasicTestAsync()
        {
            basicTestAsync = true;
        }

        [Test]
        public void BasicTestTask()
        {
            BasicTestTaskAsync();
            basicTestTaskAsync.AssertTrue();
        }

        async Task BasicTestTaskAsync()
        {
            basicTestTaskAsync = true;
        }

        [Test]
        public async Task BasicTestTaskT()
        {
//            await BasicTestTaskAsync();
            var value = await BasicTestTaskTAsync();
            value.AssertEquals(5);
        }

        async Task<int> BasicTestTaskTAsync()
        {
            return 5;
        }

        [Test]
        public async Task TrueAsyncTestTaskT()
        {
            var taskCompletionSource = new TaskCompletionSource<int>();
            Jsni.setTimeout(() => taskCompletionSource.SetResult(4), 0);
            var value = await taskCompletionSource.Task;
            value.AssertEquals(4);
        }

        [Test]
        public async void IfStatementTrue()
        {
            int i = 5;
            if (true)
            {
                i = 6;
            }
            i.AssertEquals(6);
        }

        [Test]
        public async void IfStatementFalse()
        {
            int i = 5;
            if (false)
            {
                i = 6;
            }
            i.AssertEquals(5);
        }

        [Test]
        public async void IfElseTrue()
        {
            int i = 5;
            if (true) 
                i = 6;
            else 
                i = 7;

            i.AssertEquals(6);
        }

        [Test]
        public async void IfElseFalse()
        {
            int i = 5;
            if (false) 
                i = 6;
            else 
                i = 7;

            i.AssertEquals(7);
        }

        [Test]
        public async void WhileLoop()
        {
            var i = 0;
            while (i < 5)
            {
                i++;
            }
            i.AssertEquals(5);
        }
    }
}