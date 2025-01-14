﻿#nullable enable

using System;
using System.Linq;
using Microsoft.CodeAnalysis;
using Uno.Extensions;

#if NETFRAMEWORK
using GeneratorExecutionContext = Uno.SourceGeneration.GeneratorExecutionContext;
#endif

namespace Uno.Roslyn
{
	internal class RoslynMetadataHelper
	{
		private readonly Func<string, ITypeSymbol?> _findTypeByFullName;

		public Compilation Compilation { get; }

		public string AssemblyName => Compilation.AssemblyName!;

		public RoslynMetadataHelper(GeneratorExecutionContext context)
		{
			Compilation = context.Compilation;

			_findTypeByFullName = Funcs.Create<string, ITypeSymbol?>(SourceFindTypeByFullName).AsLockedMemoized();
		}

		public ITypeSymbol? FindTypeByFullName(string fullName)
		{
			return _findTypeByFullName(fullName);
		}

		private ITypeSymbol? SourceFindTypeByFullName(string fullName)
		{
			var symbol = Compilation.GetTypeByMetadataName(fullName);

			if (symbol?.Kind == SymbolKind.ErrorType)
			{
				symbol = null;
			}

			return symbol;
		}

		public ITypeSymbol GetTypeByFullName(string fullName)
		{
			var symbol = FindTypeByFullName(fullName);

			if (symbol == null)
			{
				throw new InvalidOperationException($"Unable to find type {fullName}");
			}

			return symbol;
		}
	}
}
