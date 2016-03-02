#include <iostream>
#include <iomanip>
#include <cstring>
#include <cassert>
#include "myString.h" 

using namespace std;

newString::newString()
{
	strLength = 0;
	strPtr = new char[1];
	strcpy(strPtr, "");
}

newString::newString(const char *str)
{
	strLength = strlen(str);
	strPtr = new char[strLength + 1];
	strcpy(strPtr, str);
}



newString::newString(const newString& rightStr)
{
	strLength = rightStr.strLength;
	strPtr = new char[strLength + 1];
	strcpy(strPtr, rightStr.strPtr);
}

newString::~newString()
{
	delete[] strPtr;
}

const newString& newString::operator=(const newString& rightStr)
{
	if (this != &rightStr)
	{
		delete[] strPtr;
		strLength = rightStr.strLength;
		strPtr = new char[strLength + 1];
		strcpy(strPtr, rightStr.strPtr);
	}

	return *this;
}

char& newString::operator[](int index)
{
	assert(0 <= index && index < strLength);
	return strPtr[index];
}

const char& newString::operator[](int index) const
{
	assert(0 <= index && index < strLength);
	return strPtr[index];
}


bool newString::operator==(const newString& rightStr) const
{
	return(strPtr, rightStr.strPtr) == 0;
}

bool newString::operator<=(const newString& rightStr) const
{
	return(strPtr, rightStr.strPtr) <= 0;
}

bool newString::operator<(const newString& rightStr) const
{
	return(strPtr, rightStr.strPtr) <0;
}

bool newString::operator>(const newString& rightStr) const
{
	return(strPtr, rightStr.strPtr) > 0;
}

bool newString::operator>=(const newString& rightStr) const
{
	return(strPtr, rightStr.strPtr) >= 0;
}

bool newString::operator!=(const newString& rightStr) const
{
	return(strPtr, rightStr.strPtr) != 0;
}

ostream& operator<<(ostream& osObject, const newString& str)
{
	osObject << str.strPtr;
	return osObject;
}

istream& operator >>(istream& isObject, newString& str)
{
	char temp[81];
	isObject >> setw(81) >> temp;
	str = temp;
	return isObject;
}