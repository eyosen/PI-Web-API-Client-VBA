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

	[Guid("6D62E07C-F828-4550-B370-EADA66BC0F4D")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPITimeRuleLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string Analysis { get; set; }

		[DispId(3)]
		string AnalysisTemplate { get; set; }

		[DispId(4)]
		string PlugIn { get; set; }

	}

	[Guid("AF7A7631-9A12-438A-AE66-CDEF01EF005D")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPITimeRuleLinks))]
	[ProgId("PIWebAPIWrapper.PITimeRuleLinks")]
	[DataContract]

	public class PITimeRuleLinks : IPITimeRuleLinks
	{
		public PITimeRuleLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "Analysis", EmitDefaultValue = false)]
		public string Analysis { get; set; }

		[DataMember(Name = "AnalysisTemplate", EmitDefaultValue = false)]
		public string AnalysisTemplate { get; set; }

		[DataMember(Name = "PlugIn", EmitDefaultValue = false)]
		public string PlugIn { get; set; }

	}
}
