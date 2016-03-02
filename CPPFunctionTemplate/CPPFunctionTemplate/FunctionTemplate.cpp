#include <iostream>
#include "myString.h"
using namespace std;

template<class Type>
Type larger(Type x, Type y);

int main()
{
	cout << "Larger of 5 and 6 " << larger(5, 6) << endl;
	cout << "Larger of A and B = " << larger('A', 'B') << endl;
	cout << "Larger of 5.6 and 3.2 = " << larger(5.6, 3.2) << endl;

	newString str1 = "Hello";
	newString str2 = "Happy";

	cout << "Larger of " << str1 << " and " << str2;

	return 0;
}

template <class Type>
Type larger(Type x, Type y)
{
	if (x >= y)
		return x;
}