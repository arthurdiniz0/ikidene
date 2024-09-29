using System.Reflection;

namespace Language.Lua
{
	public class LuaMethodFunction : LuaFunction
	{
		public LuaMethodFunction(object target, MethodInfo method) : base(default(LuaFunc))
		{
		}

	}
}
