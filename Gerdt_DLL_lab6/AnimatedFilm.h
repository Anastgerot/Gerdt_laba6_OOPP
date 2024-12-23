#pragma once
#include "pch.h"
#include "films.h"

class AnimatedFilm : public films
{
	friend class boost::serialization::access;

protected:
	string voice_actors = "";
	string animation_style = "";

public:
	void setVoiceActors(const string& voice_actors) { this->voice_actors = voice_actors;}
	void setAnimationStyle(const string& animation_style) { this->animation_style = animation_style;}

	string getVoiceActors() const {return voice_actors;}
	string getAnimationStyle() const {return animation_style;}

	BOOST_SERIALIZATION_SPLIT_MEMBER()

	virtual ~AnimatedFilm() {}

	template<class Archive>
	void save(Archive& ar, const unsigned int version) const
	{
		ar& boost::serialization::base_object<films>(*this);
		ar& voice_actors;
		ar& animation_style;
	}

	template<class Archive>
	void load(Archive& ar, const unsigned int version)
	{
		ar& boost::serialization::base_object<films>(*this);
		ar& voice_actors;
		ar& animation_style;
	}
};

BOOST_CLASS_VERSION(AnimatedFilm, 1);

