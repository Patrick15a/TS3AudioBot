// TS3Client - A free TeamSpeak3 client implementation
// Copyright (C) 2017  TS3Client contributors
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the Open Software License v. 3.0
//
// You should have received a copy of the Open Software License along with this
// program. If not, see <https://opensource.org/licenses/OSL-3.0>.

namespace TS3Client.Messages
{
	using System;
	using System.Collections.Generic;

	public interface IMessage
	{
		void SetField(string name, ReadOnlySpan<byte> value);
		void Expand(IMessage[] to, IEnumerable<string> flds);
	}

	public interface INotification : IMessage
	{
		NotificationType NotifyType { get; }
	}

	public interface IResponse : IMessage
	{
		string ReturnCode { get; set; }
	}
}
