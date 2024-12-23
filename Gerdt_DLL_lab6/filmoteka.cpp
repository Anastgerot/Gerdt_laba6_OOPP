#include "pch.h"
#include "filmoteka.h"
#include "Utils.h"

void filmoteka::Add(shared_ptr<films> film) {
    movies.push_back(film);
}

int filmoteka::GetSize() const {
    return static_cast<int>(movies.size());
}

shared_ptr<films> filmoteka::Getfilm(int id) const {
    if (id < 0 || id >= GetSize()) {
        throw out_of_range("Invalid film ID");
    }
    return movies[id];
}

void filmoteka::Delete(int id) {
    if (id < 0 || id >= GetSize()) {
        throw out_of_range("Invalid film ID");
    }
    movies.erase(movies.begin() + id);
}

void filmoteka::Clear_Films() {
    movies.clear();
}

void filmoteka::Save_movies(const string& filename) {
    ofstream fout(filename);
    if (!fout) {
        return;
    }
    boost::archive::text_oarchive oa(fout);
    oa << movies;
}

void filmoteka::Load_movies(const string& filename) {

    ifstream fin(filename);
    if (!fin) {
        return;
    }
    boost::archive::text_iarchive ia(fin);
    movies.clear();
    ia >> movies;
}