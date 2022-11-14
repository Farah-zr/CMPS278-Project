import React, { useState } from 'react'
import { Tab, Tabs } from 'react-bootstrap'


export default function ReactTabs() {
  const [tabKey, setTabKey] = useState('/')
  return (
    <div>
      <h2 className="mb-3">React Js Tabs Component Example</h2>
      <Tabs activeKey={tabKey} onSelect={(e) => setTabKey(e)}>
        <Tab eventKey="/" title="All">
          <p>Tab 1</p>
          <p>
            Lorem ipsum dolor sit amet, consectetur adipiscing elit. Ut sed enim
            semper mi congue vestibulum.
          </p>
        </Tab>
        <Tab eventKey="african" title="African">
          <p>Tab 2</p>
        </Tab>
        <Tab eventKey="chinese" title="Chinese">
          <p>Tab 3</p>
        </Tab>
        <Tab eventKey="italian" title="Italian">
          <p>Tab 4</p>
        </Tab>
      </Tabs>
    </div>
  )
}