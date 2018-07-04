// ************************************************************************
//
// * Copyright 2018 OSIsoft, LLC
// * Licensed under the Apache License, Version 2.0 (the "License");
// * you may not use this file except in compliance with the License.
// * You may obtain a copy of the License at
// * 
// *   <http://www.apache.org/licenses/LICENSE-2.0>
// * 
// * Unless required by applicable law or agreed to in writing, software
// * distributed under the License is distributed on an "AS IS" BASIS,
// * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// * See the License for the specific language governing permissions and
// * limitations under the License.
// ************************************************************************

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using PIWebAPIWrapper.Client;
using System.Runtime.InteropServices;

namespace PIWebAPIWrapper.Model
{

	[Guid("ED45D59D-00E4-4788-BF0F-DCC8A46E6EA7")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIChannelInstance
	{
		[DispId(1)]
		string Id { get; set; }

		[DispId(2)]
		string StartTime { get; set; }

		[DispId(3)]
		string LastMessageSentTime { get; set; }

		[DispId(4)]
		int SentMessageCount { get; set; }

		[DispId(5)]
		PIWebException WebException { get; set; }

	}

	[Guid("19EC77A1-D633-419B-85FB-223E36BF20EC")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIChannelInstance))]
	[ProgId("PIWebAPIWrapper.PIChannelInstance")]
	[DataContract]

	public class PIChannelInstance : IPIChannelInstance
	{
		public PIChannelInstance()
		{
		}

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		[DataMember(Name = "StartTime", EmitDefaultValue = false)]
		public string StartTime { get; set; }

		[DataMember(Name = "LastMessageSentTime", EmitDefaultValue = false)]
		public string LastMessageSentTime { get; set; }

		[DataMember(Name = "SentMessageCount", EmitDefaultValue = false)]
		public int SentMessageCount { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
