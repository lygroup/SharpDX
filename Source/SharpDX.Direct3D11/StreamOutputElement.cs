// Copyright (c) 2010-2013 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System;

using SharpDX.Serialization;

namespace SharpDX.Direct3D11
{
    public partial struct StreamOutputElement : IDataSerializable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StreamOutputElement"/> struct.
        /// </summary>
        /// <param name="streamIndex">Zero-based, stream number</param>
        /// <param name="semanticName">Name of the semantic.</param>
        /// <param name="semanticIndex">Index of the semantic.</param>
        /// <param name="startComponent">The start component.</param>
        /// <param name="componentCount">The component count.</param>
        /// <param name="outputSlot">The output slot.</param>
        public StreamOutputElement(int streamIndex, string semanticName, int semanticIndex, byte startComponent, byte componentCount, byte outputSlot)
        {
            Stream = streamIndex;
            SemanticName = semanticName;
            SemanticIndex = semanticIndex;
            StartComponent = startComponent;
            ComponentCount = componentCount;
            OutputSlot = outputSlot;
        }

        void IDataSerializable.Serialize(BinarySerializer serializer)
        {
            serializer.Serialize(ref Stream);
            serializer.Serialize(ref SemanticName);
            serializer.Serialize(ref SemanticIndex);
            serializer.Serialize(ref StartComponent);
            serializer.Serialize(ref ComponentCount);
            serializer.Serialize(ref OutputSlot);
        }
    }
}