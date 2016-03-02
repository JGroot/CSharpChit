#ifndef MYSTRING_H
#define MYSTRING_H

#include <iostream>
using namespace std;

class newString
{
	friend ostream& operator << (ostream&, const newString&);
	friend istream& operator >> (istream&, newString&);

private:
	char *strPtr;
	int strLength;

public:
	newString();
	~newString();
	newString(const newString&);
	newString(const char*);
	const newString& operator = (const newString&);

	char &operator[](int);
	const char &operator[] (int)const;

	bool operator == (const newString&) const;
	bool operator != (const newString&) const;
	bool operator <= (const newString&) const;
	bool operator >= (const newString&) const;
	bool operator < (const newString&) const;
	bool operator > (const newString&) const;
};

#endif