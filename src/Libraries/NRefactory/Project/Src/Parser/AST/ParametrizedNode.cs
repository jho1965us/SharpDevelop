// ConstructorDeclaration.cs
// Copyright (C) 2003 Mike Krueger (mike@icsharpcode.net)
// 
// This program is free software; you can redistribute it and/or
// modify it under the terms of the GNU General Public License
// as published by the Free Software Foundation; either version 2
// of the License, or (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with this program; if not, write to the Free Software
// Foundation, Inc., 59 Temple Place - Suite 330, Boston, MA  02111-1307, USA.

using System;
using System.Diagnostics;
using System.Collections.Generic;

namespace ICSharpCode.NRefactory.Parser.AST
{
	public abstract class ParametrizedNode : AttributedNode
	{
		protected string                               name = String.Empty;
		protected List<ParameterDeclarationExpression> parameters;
		
		public string Name {
			get {
				return name;
			}
			set {
				name = value == null ? String.Empty : value;
			}
		}
		
		public List<ParameterDeclarationExpression> Parameters {
			get {
				return parameters;
			}
			set {
				parameters = value == null ? new List<ParameterDeclarationExpression>(1) : value;
			}
		}
		
		public ParametrizedNode(Modifier modifier, List<AttributeSection> attributes) : this(modifier, attributes, null)
		{
		}
		
		public ParametrizedNode(Modifier modifier, List<AttributeSection> attributes, string name) : this(modifier, attributes, name, null)
		{
		}
		
		public ParametrizedNode(Modifier modifier, List<AttributeSection> attributes, string name, List<ParameterDeclarationExpression> parameters) : base(modifier, attributes)
		{
			// use properties because of the null check.
			this.Name       = name;
			this.Parameters = parameters;
		}
	}
}
