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

	[Guid("689B3338-F14E-4568-9D1B-FE448A48DF6A")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPICacheInstance
	{
		[DispId(1)]
		string Id { get; set; }

		[DispId(2)]
		string LastRefreshTime { get; set; }

		[DispId(3)]
		string WillRefreshAfter { get; set; }

		[DispId(4)]
		string ScheduledExpirationTime { get; set; }

		[DispId(5)]
		string User { get; set; }

		[DispId(6)]
		PIWebException WebException { get; set; }

	}

	[Guid("C9F3DC55-6BA8-480F-BBF8-C891E8C7F0A5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPICacheInstance))]
	[ProgId("PIWebAPIWrapper.PICacheInstance")]
	[DataContract]

	public class PICacheInstance : IPICacheInstance
	{
		public PICacheInstance()
		{
		}

		[DataMember(Name = "Id", EmitDefaultValue = false)]
		public string Id { get; set; }

		[DataMember(Name = "LastRefreshTime", EmitDefaultValue = false)]
		public string LastRefreshTime { get; set; }

		[DataMember(Name = "WillRefreshAfter", EmitDefaultValue = false)]
		public string WillRefreshAfter { get; set; }

		[DataMember(Name = "ScheduledExpirationTime", EmitDefaultValue = false)]
		public string ScheduledExpirationTime { get; set; }

		[DataMember(Name = "User", EmitDefaultValue = false)]
		public string User { get; set; }

		[DataMember(Name = "WebException", EmitDefaultValue = false)]
		public PIWebException WebException { get; set; }

	}
}
