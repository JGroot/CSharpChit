#ifndef LISTTYPE_H
#define LISTTYPE_H

#include <iostream>
#include <cassert>
using namespace std;

template <class elemType>
class listType
{
private:
	int maxSize;
	int length;
	elemType *list; //point to the array that holds the list items
public:
	listType(int listSize = 50);
	listType();

	bool isEmpty() const;
	bool isFull() const; 
	int getLength() const;
	int getMaxSize() const;
	void sort();
	void print() const;
	void insertAt(const elemType& item, int position); 
//	void ~listType();
};

template <class elemType>
bool listType<elemType>::isEmpty() const
{
	return (length == 0);
}

template <class elemType>
bool listType<elemType>::isFull() const
{
	return (length == maxSize);
}

template <class elemType>
int listType<elemType>::getLength() const
{
	return length;
}

template <class elemType>
int listType<elemType>::getMaxSize() const
{
	return maxSize;
}

template <class elemType>
listType<elemType>::listType(int listSize)
{
	maxSize = listSize;
	length = 0;
	list = new elemType[maxSize];
}

//template <class elemType>
//listType<elemType>::~listType()
//{
//	delete[] list;
//}

template <class elemType>
void listType<elemType>::sort()
{
	int i, j;
	int min;
	elemType temp;
	
	for (i = 0; i < length; i++ )
	{
		min == i;
		for (j = i + 1; j < length; j++)
			if (list[j] < list[min])
				min = j;

		temp = list[i];
		list[i] = list[min];
		list[min] = temp;
	}
}

template <class elemType>
void listType<elemType>::print() const
{
	int i;
	for (i = 0; i < length; i++)
		cout << list[i] << "    ";
	cout << endl;
}

template <class elemType>
void listType<elemType>::insertAt(const elemType& item, int position)
{
	assert(position >= 0 && psition < maxsize);
	list[position] = item;
	length++;
}
#endif 