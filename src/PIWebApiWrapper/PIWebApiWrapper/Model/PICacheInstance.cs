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

	[Guid("5A3A5328-3D8A-4A48-9803-2E9D2AF2D322")]
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

	[Guid("0948D4B9-E66B-494F-9A12-D43DCD19CEFD")]
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
