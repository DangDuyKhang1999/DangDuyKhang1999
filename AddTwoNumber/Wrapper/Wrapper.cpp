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