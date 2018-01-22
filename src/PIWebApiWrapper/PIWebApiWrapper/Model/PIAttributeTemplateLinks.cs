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

	[Guid("29420943-CA02-4B4F-AFF9-5B55943EC580")]
	[ComVisible(true)]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]

	public interface IPIAttributeTemplateLinks
	{
		[DispId(1)]
		string Self { get; set; }

		[DispId(2)]
		string AttributeTemplates { get; set; }

		[DispId(3)]
		string ElementTemplate { get; set; }

		[DispId(4)]
		string Parent { get; set; }

		[DispId(5)]
		string Categories { get; set; }

		[DispId(6)]
		string Trait { get; set; }

	}

	[Guid("AF553E06-F724-457D-8890-23CC48FA28A5")]
	[ComVisible(true)]
	[ClassInterface(ClassInterfaceType.None)]
	[ComSourceInterfaces(typeof(IPIAttributeTemplateLinks))]
	[ProgId("PIWebAPIWrapper.PIAttributeTemplateLinks")]
	[DataContract]

	public class PIAttributeTemplateLinks : IPIAttributeTemplateLinks
	{
		public PIAttributeTemplateLinks()
		{
		}

		[DataMember(Name = "Self", EmitDefaultValue = false)]
		public string Self { get; set; }

		[DataMember(Name = "AttributeTemplates", EmitDefaultValue = false)]
		public string AttributeTemplates { get; set; }

		[DataMember(Name = "ElementTemplate", EmitDefaultValue = false)]
		public string ElementTemplate { get; set; }

		[DataMember(Name = "Parent", EmitDefaultValue = false)]
		public string Parent { get; set; }

		[DataMember(Name = "Categories", EmitDefaultValue = false)]
		public string Categories { get; set; }

		[DataMember(Name = "Trait", EmitDefaultValue = false)]
		public string Trait { get; set; }

	}
}
