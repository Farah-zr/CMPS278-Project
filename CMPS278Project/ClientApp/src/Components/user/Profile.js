import React from "react";
import "../../assets/styles/profile.css";

const Profile = () => {
  return (
    <>
      <section>
        <p>profile (coming soon)</p>
        {/* <section>
          <section className="profile-container">
            {loading ? (
              <motion.div
                variants={loaderVariants}
                animate="animationOne"
                className="updating-ball"
              ></motion.div>
            ) : (
              <article>
                {events &&
                  events.map((item) => (
                    <article key={item.id}>
                      <summary>
                        <img
                          src={item.img}
                          className="profile-img"
                          alt="user"
                        />
                        <section className="profile-details">
                          <h1 className="profile-name">{item.name}</h1>
                          <p className="profile-loc">Email: {item.email}</p>
                          <p className="profile-loc">
                            Date Of Birth: {item.date}
                          </p>
                          <p className="profile-loc">
                            Location: {item.location}
                          </p>
                          <button
                            onClick={() => navigate(`/update/${item.id}`)}
                            className="profile-btn"
                          >
                            Edit Profile
                          </button>
                        </section>
                      </summary>
                    </article>
                  ))}
              </article>
            )}
          </section>
        </section> */}
      </section>
    </>
  );
};

export default Profile;
