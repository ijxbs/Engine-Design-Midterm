#define EXPORT_API __declspec(dllexport)

#include <iostream>

extern "C"
{
	int EXPORT_API PrintANumber() {
		return 5;
	}

	float EXPORT_API ModifyWinLoss(float w, float l)
	{
		return w + l;
	}
}

int main() {

	std::cout << ModifyWinLoss(2.0, 3.0);
}