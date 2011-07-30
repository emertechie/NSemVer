﻿namespace NSemVer
{
	public interface IChangeVisitor
	{
		void Visit(ModuleChange change);

		void Visit(TypeChange change);

		void Visit(MethodChange change);

		void Visit(ParameterChange change);
	}
}