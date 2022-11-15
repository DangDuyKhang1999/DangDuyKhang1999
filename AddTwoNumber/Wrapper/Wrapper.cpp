#include "pch.h"

#include "Wrapper.h"
Wrapper::WrapperForCaculatorTwoNumber::WrapperForCaculatorTwoNumber()
{
	pCalculator = new Calculator();
}

Wrapper::WrapperForCaculatorTwoNumber::~WrapperForCaculatorTwoNumber()
{
	if (pCalculator != nullptr)
		delete pCalculator;
}

int Wrapper::WrapperForCaculatorTwoNumber::GetSumInCaculatorClass(int iA, int iB)
{
	int result = 0;
	pCalculator->setSoA(iA);
	pCalculator->setSoB(iB);
	result = pCalculator->getSum();
	return result;
}