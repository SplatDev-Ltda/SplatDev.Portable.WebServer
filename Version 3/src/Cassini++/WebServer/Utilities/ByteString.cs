/* **********************************************************************************
 *
 * Copyright (c) Microsoft Corporation. All rights reserved.
 *
 * This source code is subject to terms and conditions of the Microsoft Public
 * License (Ms-PL). A copy of the license can be found in the license.htm file
 * included in this distribution.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * **********************************************************************************/

using System;
using System.Collections.Generic;
using System.Text;

namespace PiW.WebServer.Utilities
{
	public class ByteString
	{
		private byte[] _bytes;
		private int _offset;
		private int _length;

		public ByteString(byte[] bytes, int offset, int length)
		{
            if (bytes == null)
            {
                throw new ArgumentNullException("bytes");
            }

			_bytes = bytes;

            if (offset > bytes.Length || offset < 0)
            {
                throw new ArgumentOutOfRangeException("offset");
            }

			_offset = offset;

            if (offset + length > bytes.Length || length < 0)
            {
                throw new ArgumentOutOfRangeException("length");
            }

            _length = length;
		}

		public byte[] Bytes
		{
			get { return _bytes; }
		}

		public bool IsEmpty
		{
			get { return (_bytes == null || _length == 0); }
		}

		public string GetString()
		{
			return GetString(Encoding.UTF8);
		}

		private string GetString(Encoding enc)
		{
			if (IsEmpty)
			{
				return string.Empty;
			}
			return enc.GetString(_bytes, _offset, _length);
		}

		public byte[] GetBytes()
		{
			byte[] bytes = new byte[_length];
			if (_length > 0)
			{
				Buffer.BlockCopy(_bytes, _offset, bytes, 0, _length);
			}
			return bytes;
		}

		public int IndexOf(char ch)
		{
			return IndexOf(ch, 0);
		}

		private int IndexOf(char ch, int offset)
		{
			for (int i = offset; i < _length; i++)
			{
				if (this[i] == (byte) ch)
				{
					return i;
				}
			}
			return -1;
		}

		public ByteString Substring(int offset)
		{
			return Substring(offset, _length - offset);
		}

		private ByteString Substring(int offset, int len)
		{
			return new ByteString(_bytes, _offset + offset, len);
		}

		public ByteString[] Split(char sep)
		{
			var list = new List<ByteString>();

			int pos = 0;
			while (pos < _length)
			{
				int i = IndexOf(sep, pos);
				if (i < 0)
				{
					break;
				}

				list.Add(Substring(pos, i - pos));
				pos = i + 1;

				while (this[pos] == (byte) sep && pos < _length)
				{
					pos++;
				}
			}

			if (pos < _length)
			{
				list.Add(Substring(pos));
			}

			return list.ToArray();
		}

        private byte this[int index]
        {
            get { return _bytes[_offset + index]; }
        }
	}
}