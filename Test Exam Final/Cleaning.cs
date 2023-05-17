using System;

public class Cleaning
{
	int _area;
	bool _deluxeIncl, _doubleWashIncl, _impregIncl;
	public Cleaning(int area, bool deluxeIncl, bool doubleWashIncl, bool impregIncl)
	{
		_area = area;
		if (deluxeIncl)
		{
			_deluxeIncl = deluxeIncl;
			_doubleWashIncl = false;
			_impregIncl = false;
		}
		else
		{
			_doubleWashIncl= doubleWashIncl;
			_impregIncl= impregIncl;
		}
	}
}
