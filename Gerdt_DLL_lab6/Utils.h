#pragma once
#include "pch.h"

template <typename T>
T GetCorrectNumber(T min, T max)
{
	T a;
	while ((cin >> a).fail() || a < min || a > max || cin.peek() != '\n')
	{
		cin.clear();
		cin.ignore(1000, '\n');
		cout << "¬ведите число (" "от" << " " << min << " " << "до" << " " << max << "): ";
	}
	return a;
}