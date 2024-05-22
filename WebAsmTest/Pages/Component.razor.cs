using Microsoft.AspNetCore.Components;

namespace WebAsmTest.Pages
{
	public partial class Component : ComponentBase
	{
		private int currentCount = 0;

		private void IncrementCount()
		{
			currentCount++;
		}

	}
}
