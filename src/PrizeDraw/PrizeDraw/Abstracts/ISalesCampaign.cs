using PrizeDraw.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrizeDraw.Abstracts
{
	//Interface cane used for DI and Unit Testing but left out in this solution
	public interface ISalesCampaign
	{
		List<int> OrdersToDraw { get; set; }
		void RemoveCurrentHighAndLow();
		void DailyDraw();
		int GetTotalPrizeMoney();
	}
}
