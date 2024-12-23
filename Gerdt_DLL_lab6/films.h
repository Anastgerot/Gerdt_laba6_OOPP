#pragma once
#include "pch.h"
class films
{
	friend class boost::serialization::access;	
protected:
	string title = "";
	int year = 0;
	string genre = "";
	double rating = 0;
	string country = "";
	string director = "";
	bool is_available = false;

	template<class Archive>
	void serialize(Archive& ar, const unsigned int version) {
		ar& title;
		ar& year;
		ar& genre;
		ar& rating;
		ar& country;
		ar& director;
		ar& is_available;
	}
public:
	virtual ~films() = default;

	string getTitle() const { return title; }
	int getYear() const { return year; }
	string getGenre() const { return genre; }
	double getRating() const { return rating; }
	string getCountry() const { return country; }
	string getDirector() const { return director; }
	bool isAvailable() const { return is_available; }

	void setTitle(const string& t) { title = t; }
	void setYear(int y) { year = y; }
	void setGenre(const string& genre) { this->genre = genre; }
	void setRating(double rating) { this->rating = rating; }
	void setDirector(const string& director) { this->director = director; }
	void setCountry(const string& country) { this->country = country; }
	void setAvailability(bool is_available) { this->is_available = is_available; }
};
