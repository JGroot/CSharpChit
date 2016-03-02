#include <iostream>
#include "listType.h"
#include "myString.h"
using namespace std;

int main()
{
	listType<int> intList(100);
	listType<newString> stringList;

	int index;
	int number;

	cout << "Processing the integer list .... " << endl;
	cout << "Enter 5 integers: ";

	for (index = 0; index < 5; index++)
	{
		cin >> number;
		intList.insertAt(number, index);
	}

	cout << endl;
	cout << "intList: ";
	intList.print();
	cout << endl;

	intList.sort();
	cout << "After sorting, intList: ";
	intList.print();
	cout << endl;

	newString str;

	cout << "Processing the string list...." << endl;
	cout << "Enter 5 string:  ";
	for (index = 0; index < 5; index++)
	{
		cin >> str;
		stringList.insertAt(str, index);

	}
		
	cout << endl;
	cout << "stringList:  ";
	stringList.print();
	cout << endl;

	stringList.sort();
	cout << "After sorting, stringList: ";
	stringList.print();
	cout << endl;

	int intListSize;

	cout << "Enter the size of the integer list: ";
	cin >> intListSize;
	cout << endl;

	listType<int> intList2(intListSize);

	cout << "Processing the string list...." << endl;
	cout << "Enter" << intListSize << " integers: ";
	for (index = 0; index < intListSize; index++)
	{
		cin >> number;
		intList2.insertAt(number, index);

	}

	cout << endl;

	cout << "intList2: ";
	intList2.print();
	cout << endl;

	intList2.sort();
	cout << "After sorting, intList2: ";
	intList2.print();
	cout << endl;

	cout << "Length of intiList2: " << intList2.getLength() << endl;
	cout << "Maximum size of intList2: " << intList2.getMaxSize() << endl;

	cout << "Hit the Enter key to continue....";
	cin.get();
	return 0;
}

