#pragma once
using namespace std;
class  Calculator
{
private:
	int m_iSoA =1;
	int m_iSoB =2;
public:
	Calculator();
	int getSoA();
	void setSoA(int iSoA);
	int getSoB();
	void setSoB(int iSoB);
	int getSum();
};