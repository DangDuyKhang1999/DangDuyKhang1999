#pragma once

using namespace System;
#include "E:\AppStudentManagement\AddTwoNumber\AddTwoNumber\CalculatorTwoNumber.cpp"
namespace Wrapper {
	public ref class WrapperForCaculatorTwoNumber
	{
	public:
		WrapperForCaculatorTwoNumber();
		~WrapperForCaculatorTwoNumber();
	private:
		Calculator *pCalculator;
	};
}
