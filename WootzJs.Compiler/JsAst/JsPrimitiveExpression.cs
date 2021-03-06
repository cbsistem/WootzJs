#region License
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

namespace WootzJs.Compiler.JsAst
{
    public class JsPrimitiveExpression : JsExpression
    {
        private object value;

        public JsPrimitiveExpression()
        {
        }

        public JsPrimitiveExpression(bool value)
        {
            this.value = value;
        }

        public JsPrimitiveExpression(int value)
        {
            this.value = value;
        }

        public JsPrimitiveExpression(long value)
        {
            this.value = value;
        }

        public JsPrimitiveExpression(char value)
        {
            this.value = value;
        }

        public JsPrimitiveExpression(uint value)
        {
            this.value = value;
        }

        public JsPrimitiveExpression(float value)
        {
            this.value = value;
        }

        public JsPrimitiveExpression(double value)
        {
            this.value = value;
        }

        public JsPrimitiveExpression(string value)
        {
            this.value = value;
        }

        public object Value
        {
            get { return value; }
        }

        public override void Accept(IJsVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override T Accept<T>(IJsVisitor<T> visitor)
        {
            return visitor.Visit(this);
        }
    }
}
