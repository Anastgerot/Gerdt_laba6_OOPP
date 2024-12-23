#include "pch.h"
#include "filmoteka.h"
#include "Utils.h"

void filmoteka::start() {
    SetConsoleCP(1251);
    SetConsoleOutputCP(1251);
    locale::global(locale("Russian"));
}

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
