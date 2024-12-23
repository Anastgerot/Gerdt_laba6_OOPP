
#include "pch.h"
#include "framework.h"
#include "filmoteka.h"


BOOL APIENTRY DllMain(HMODULE hModule,
    DWORD  ul_reason_for_call,
    LPVOID lpReserved
)
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}
filmoteka film_library;

struct film_struct {
    char title[256];
    int year;
    char genre[256];
    float rating;
    char country[256];
    char director[256];
    char voice_actors[256];
    char animation_style[256];
    bool is_available;
};

extern "C" {

    _declspec(dllexport) void __stdcall LoadFilm(const char* filename) {
        film_library.Load_movies(filename);
    }

    _declspec(dllexport) void __stdcall Save(const char* filename) {
        film_library.Save_movies(filename);
    }

    _declspec(dllexport) void Clear() {
        film_library.Clear_Films();
    }

    _declspec(dllexport) void __stdcall UpdateFilm(film_struct& film_data, int id)
    {
        if (id < 0 || id >= film_library.GetSize()) return;

        auto base_film = film_library.Getfilm(id);
        if (!base_film) return;

        base_film->setTitle(film_data.title);
        base_film->setYear(film_data.year); 
        base_film->setGenre(film_data.genre);
        base_film->setRating(film_data.rating);
        base_film->setCountry(film_data.country);
        base_film->setDirector(film_data.director);
        base_film->setAvailability(film_data.is_available);

        if (auto animated_film = dynamic_pointer_cast<AnimatedFilm>(base_film)) {
            animated_film->setVoiceActors(film_data.voice_actors);
            animated_film->setAnimationStyle(film_data.animation_style);
        }
    }


    _declspec(dllexport) void __stdcall AddFilm(int param) {
        if (param == 0) {
            auto film = make_shared<films>();
            film->setTitle("Новый фильм");
            film->setYear(0);
            film->setGenre("");
            film->setRating(0.0);
            film->setCountry("");
            film->setDirector("");
            film->setAvailability(false);
            film_library.Add(film);

        }
        else {
            auto af = make_shared<AnimatedFilm>();
            af->setTitle("Новый анимационный фильм");
            af->setYear(0);
            af->setGenre("");
            af->setRating(0.0);
            af->setCountry("");
            af->setDirector("");
            af->setAvailability(false);
            af->setVoiceActors("");
            af->setAnimationStyle("");
            film_library.Add(af);
        }
    }

    _declspec(dllexport) void __stdcall GetFilm(film_struct& film_data, int id)
    {
        if (id < 0 || id >= film_library.GetSize()) return;
        auto base_film = film_library.Getfilm(id);

        strcpy_s(film_data.title, base_film->getTitle().c_str());
        film_data.year = base_film->getYear();
        strcpy_s(film_data.genre, base_film->getGenre().c_str());
        film_data.rating = base_film->getRating();
        strcpy_s(film_data.country, base_film->getCountry().c_str());
        strcpy_s(film_data.director, base_film->getDirector().c_str());
        film_data.is_available = base_film->isAvailable();

        auto animated_film = dynamic_pointer_cast<AnimatedFilm>(base_film);
        if (animated_film) {
            strcpy_s(film_data.voice_actors, animated_film->getVoiceActors().c_str());
            strcpy_s(film_data.animation_style, animated_film->getAnimationStyle().c_str());
        }
    }

    _declspec(dllexport) int GetSize() {
        return film_library.GetSize();
    }

    _declspec(dllexport) void DeleteFilm(int id) {
        film_library.Delete(id);
    }
}

