import React, { useState } from "react";
import Heart from "react-animated-heart";

const HeartWithClick = () => {
    const [isclick, setClick] = useState(false);
    return (
        <Heart isClick={isclick} onClick={() => setClick(!isclick)} />
    );
  }

  export default HeartWithClick;