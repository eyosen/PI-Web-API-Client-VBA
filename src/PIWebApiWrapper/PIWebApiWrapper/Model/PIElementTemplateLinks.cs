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

	[Guid("1E6480FA-87D7-4FEE-AC02-3696AD748136")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIElementTemplateLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string AnalysisTemplates { get; set; }

		[DispId(3)]
		string AttributeTemplates { get; set; }

		[DispId(4)]
		string Database { get; set; }

		[DispId(5)]
		string Categories { get; set; }

		[DispId(6)]
		string BaseTemplate { get; set; }

		[DispId(7)]
		string DefaultAttribute { get; set; }

		[DispId(8)]
		string Security { get; set; }

		[DispId(9)]
		string SecurityEntries { get; set; }

	}

	[Guid("39DDD521-D9EE-4032-A111-348164CFB111")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIElementTemplateLinks))]
	[ProgId("PIWebAPIWrapper.PIElementTemplateLinks")]
	[DataContract]

	public class PIElementTemplateLinks : IPIElementTemplateLinks
	{
		public PIElementTemplateLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "AnalysisTemplates", EmitDefaultValue = false)]
		public string AnalysisTemplates { get; set; }

		[DataMember(Name = "AttributeTemplates", EmitDefaultValue = false)]
		public string AttributeTemplates { get; set; }

		[DataMember(Name = "Database", EmitDefaultValue = false)]
		public string Database { get; set; }

		[DataMember(Name = "Categories", EmitDefaultValue = false)]
		public string Categories { get; set; }

		[DataMember(Name = "BaseTemplate", EmitDefaultValue = false)]
		public string BaseTemplate { get; set; }

		[DataMember(Name = "DefaultAttribute", EmitDefaultValue = false)]
		public string DefaultAttribute { get; set; }

		[DataMember(Name = "Security", EmitDefaultValue = false)]
		public string Security { get; set; }

		[DataMember(Name = "SecurityEntries", EmitDefaultValue = false)]
		public string SecurityEntries { get; set; }

	}
}
