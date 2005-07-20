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
	public abstract class AttributedNode : AbstractNode
	{
		protected List<AttributeSection> attributes;
		protected Modifier               modifier;
		
		public List<AttributeSection> Attributes {
			get {
				return attributes;
			}
			set {
				attributes = value == null ? new List<AttributeSection>(1) : value;
			}
		}
		
		public Modifier Modifier {
			get {
				return modifier;
			}
			set {
				modifier = value;
			}
		}
		
		public AttributedNode(List<AttributeSection> attributes) : this(Modifier.None, attributes)
		{
		}
		
		public AttributedNode(Modifier modifier, List<AttributeSection> attributes)
		{
			this.modifier   = modifier;
			
			// use property because of the null check.
			this.Attributes = attributes;
		}
		
	}
}
