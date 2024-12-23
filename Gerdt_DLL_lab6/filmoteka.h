#pragma once
#include "pch.h"
#include "Utils.h"
#include "films.h"
#include "AnimatedFilm.h"
class filmoteka
{
protected:
	vector<shared_ptr<films>> movies;
public:
	template<class Archive>
	void serialize(Archive& ar, const unsigned int version) {
		ar& movies;
	}

	void start();
	void Add(shared_ptr<films> film);
	void Clear_Films();
	int GetSize() const;
	shared_ptr<films> Getfilm(int id) const; 
	void Delete(int id);
};

