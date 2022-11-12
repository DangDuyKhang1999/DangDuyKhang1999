#include "CalculatorTwoNumber.h"

Calculator::Calculator()
{
}
int Calculator::getSoA()

{
	return m_iSoA;
}

void Calculator::setSoA(int iSoA)
{
	m_iSoA = iSoA;
}

int Calculator::getSoB()
{
	return m_iSoB;
}

void Calculator::setSoB(int iSoB)
{
	m_iSoB = iSoB;
}

int Calculator::getSum()
{
	int a = m_iSoA + m_iSoB;
	return a;
}